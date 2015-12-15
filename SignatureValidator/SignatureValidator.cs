using SignatureValidator.DataTransferObject;
using System;
using System.Collections.Generic;
using System.IO;
using tr.gov.tubitak.uekae.esya.api.common.util;
using tr.gov.tubitak.uekae.esya.api.xmlsignature;
using tr.gov.tubitak.uekae.esya.api.xmlsignature.document;


public static class SignatureValidationUtil
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="signedXml">İmzası kontrol edilecek XML içeriği</param>
    /// <param name="unQaulifiedDigestAlgoritmList">Geçersiz signature.SignedInfo.SignatureMethod.Url
    /// <example>http://www.w3.org/2000/09/xmldsig#sha1</example></param>
    /// <param name="checkForEnvelopedSignature">Eğer true set edilirse İmzanın Enveloped yapısında olduğu kontrolü yapılır. Envelped yapısına olmayan İmzalarda Doğrulama sonucu başarısız döner.</param>
    /// <returns></returns>
    public static SignedDocumentValidationResult ValidateSignatureFromXml(string signedXml)
    {
        LicenseUtil.setLicenseXml(new MemoryStream(System.IO.File.ReadAllBytes(System.AppDomain.CurrentDomain.BaseDirectory + "/SignatureValidationConfig/Lisans/lisans.xml")));

        var context = new Context();
        context.Config = new tr.gov.tubitak.uekae.esya.api.xmlsignature.config.Config(System.AppDomain.CurrentDomain.BaseDirectory + "/SignatureValidationConfig/xmlsignature-config.xml");

        var file = System.IO.Path.GetTempFileName();

        System.IO.File.WriteAllText(file, signedXml);

        var sdvr = new SignedDocumentValidationResult();
        var signature = XMLSignature.parse(new FileDocument(new FileInfo(file)), context);
        var result = signature.verify();

        try
        {
            System.IO.File.Delete(file);
        }
        finally
        {

        }

        sdvr.Certificate = signature.SigningCertificate.asX509Certificate2();
        sdvr.CertificateValidationResult = new CertificateValidationResult();
        sdvr.SignatureInfo = new SignatureInfo();
        sdvr.SignatureInfo.SigningTime = signature.SigningTime;
        sdvr.CertificateValidationResult.ValidationResultList = new List<SignatureValidator.DataTransferObject.ValidationResult>();

        //
        var nodeList = signature.Document.GetElementsByTagName("UBLVersionID", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");

        if (nodeList != null && nodeList.Count > 0)
        {
            sdvr.SignatureInfo.UBLVersionID = nodeList.Item(0).InnerText;
        }

        if (context.ValidationResult != null && context.ValidationResult.getDetails() != null)
        {
            foreach (var item in context.ValidationResult.getDetails())
            {
                var vr = new SignatureValidator.DataTransferObject.ValidationResult();
                vr.Successful = item.isSuccessful();
                vr.Result = vr.Successful ? tr.gov.tubitak.uekae.esya.api.signature.ValidationResultType.VALID.ToString() : tr.gov.tubitak.uekae.esya.api.signature.ValidationResultType.INVALID.ToString();
                vr.CheckText = item.getCheckText();
                vr.ResultText = item.getResultText();
                sdvr.CertificateValidationResult.ValidationResultList.Add(vr);
            }
            sdvr.CertificateValidationResult.Successful = !sdvr.CertificateValidationResult.ValidationResultList.Exists(x => x.Successful.Equals(false));
        }

        sdvr.SignatureValidationResult = new SignatureValidator.DataTransferObject.SignatureValidationResult();
        sdvr.SignatureValidationResult.Successful = result.getResultType() == tr.gov.tubitak.uekae.esya.api.signature.ValidationResultType.VALID;
        sdvr.SignatureValidationResult.ResultText = result.getMessage() + Environment.NewLine + result.getResultType();
        sdvr.SignatureValidationResult.ValidationResultList = new List<SignatureValidator.DataTransferObject.ValidationResult>();

        foreach (var item in result.getDetails<tr.gov.tubitak.uekae.esya.api.xmlsignature.ValidationResult>())
        {
            var vr = new SignatureValidator.DataTransferObject.ValidationResult();

            vr.Successful = item.getResultType() == tr.gov.tubitak.uekae.esya.api.signature.ValidationResultType.VALID;
            vr.Result = item.getResultType().ToString();
            vr.CheckText = item.getCheckMessage();
            vr.ResultText = item.getCheckResult();

            sdvr.SignatureValidationResult.ValidationResultList.Add(vr);
        }
        return sdvr;
    }
}
