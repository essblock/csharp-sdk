          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Ess.Generated
{


// === xdr source ============================================================
//  union ManageOfferResult switch (ManageOfferResultCode code)
//  {
//  case MANAGE_OFFER_SUCCESS:
//      ManageOfferSuccessResult success;
//  default:
//      void;
//  };
//  ===========================================================================
public class ManageOfferResult {
  public ManageOfferResult () {}
  public ManageOfferResultCode Discriminant { get; set; } = new ManageOfferResultCode();
  public ManageOfferSuccessResult Success { get; set; } = default(ManageOfferSuccessResult);
  public static void Encode(IByteWriter stream, ManageOfferResult encodedManageOfferResult) {
  XdrEncoding.EncodeInt32((int)encodedManageOfferResult.Discriminant.InnerValue, stream);
  switch (encodedManageOfferResult.Discriminant.InnerValue) {
  case ManageOfferResultCode.ManageOfferResultCodeEnum.MANAGE_OFFER_SUCCESS:
  ManageOfferSuccessResult.Encode(stream, encodedManageOfferResult.Success);
  break;
  default:
  break;
  }
  }
  public static ManageOfferResult Decode(IByteReader stream) {
    ManageOfferResult decodedManageOfferResult = new ManageOfferResult();
  decodedManageOfferResult.Discriminant = ManageOfferResultCode.Decode(stream);
  switch (decodedManageOfferResult.Discriminant.InnerValue) {
  case ManageOfferResultCode.ManageOfferResultCodeEnum.MANAGE_OFFER_SUCCESS:
  decodedManageOfferResult.Success = ManageOfferSuccessResult.Decode(stream);
  break;
  default:
  break;
  }
    return decodedManageOfferResult;
  }
}
}
