          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Ess.Generated
{


// === xdr source ============================================================
//  union OperationResult switch (OperationResultCode code)
//  {
//  case opINNER:
//      union switch (OperationType type)
//      {
//      case CREATE_ACCOUNT:
//          CreateAccountResult createAccountResult;
//      case PAYMENT:
//          PaymentResult paymentResult;
//      case PATH_PAYMENT:
//          PathPaymentResult pathPaymentResult;
//      case MANAGE_OFFER:
//          ManageOfferResult manageOfferResult;
//      case CREATE_PASSIVE_OFFER:
//          ManageOfferResult createPassiveOfferResult;
//      case SET_OPTIONS:
//          SetOptionsResult setOptionsResult;
//      case CHANGE_TRUST:
//          ChangeTrustResult changeTrustResult;
//      case ALLOW_TRUST:
//          AllowTrustResult allowTrustResult;
//      case ACCOUNT_MERGE:
//          AccountMergeResult accountMergeResult;
//      case INFLATION:
//          InflationResult inflationResult;
//      case MANAGE_DATA:
//          ManageDataResult manageDataResult;
//      }
//      tr;
//  default:
//      void;
//  };
//  ===========================================================================
public class OperationResult {
  public OperationResult () {}
  public OperationResultCode Discriminant { get; set; } = new OperationResultCode();
  public OperationResultTr Tr { get; set; } = default(OperationResultTr);
  public static void Encode(IByteWriter stream, OperationResult encodedOperationResult) {
  XdrEncoding.EncodeInt32((int)encodedOperationResult.Discriminant.InnerValue, stream);
  switch (encodedOperationResult.Discriminant.InnerValue) {
  case OperationResultCode.OperationResultCodeEnum.opINNER:
  OperationResultTr.Encode(stream, encodedOperationResult.Tr);
  break;
  default:
  break;
  }
  }
  public static OperationResult Decode(IByteReader stream) {
    OperationResult decodedOperationResult = new OperationResult();
  decodedOperationResult.Discriminant = OperationResultCode.Decode(stream);
  switch (decodedOperationResult.Discriminant.InnerValue) {
  case OperationResultCode.OperationResultCodeEnum.opINNER:
  decodedOperationResult.Tr = OperationResultTr.Decode(stream);
  break;
  default:
  break;
  }
    return decodedOperationResult;
  }

  public class OperationResultTr {
    public OperationResultTr () {}
    public OperationType Discriminant { get; set; } = new OperationType();
    public CreateAccountResult CreateAccountResult { get; set; } = default(CreateAccountResult);
    public PaymentResult PaymentResult { get; set; } = default(PaymentResult);
    public PathPaymentResult PathPaymentResult { get; set; } = default(PathPaymentResult);
    public ManageOfferResult ManageOfferResult { get; set; } = default(ManageOfferResult);
    public ManageOfferResult CreatePassiveOfferResult { get; set; } = default(ManageOfferResult);
    public SetOptionsResult SetOptionsResult { get; set; } = default(SetOptionsResult);
    public ChangeTrustResult ChangeTrustResult { get; set; } = default(ChangeTrustResult);
    public AllowTrustResult AllowTrustResult { get; set; } = default(AllowTrustResult);
    public AccountMergeResult AccountMergeResult { get; set; } = default(AccountMergeResult);
    public InflationResult InflationResult { get; set; } = default(InflationResult);
    public ManageDataResult ManageDataResult { get; set; } = default(ManageDataResult);
    public static void Encode(IByteWriter stream, OperationResultTr encodedOperationResultTr) {
    XdrEncoding.EncodeInt32((int)encodedOperationResultTr.Discriminant.InnerValue, stream);
    switch (encodedOperationResultTr.Discriminant.InnerValue) {
    case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
    CreateAccountResult.Encode(stream, encodedOperationResultTr.CreateAccountResult);
    break;
    case OperationType.OperationTypeEnum.PAYMENT:
    PaymentResult.Encode(stream, encodedOperationResultTr.PaymentResult);
    break;
    case OperationType.OperationTypeEnum.PATH_PAYMENT:
    PathPaymentResult.Encode(stream, encodedOperationResultTr.PathPaymentResult);
    break;
    case OperationType.OperationTypeEnum.MANAGE_OFFER:
    ManageOfferResult.Encode(stream, encodedOperationResultTr.ManageOfferResult);
    break;
    case OperationType.OperationTypeEnum.CREATE_PASSIVE_OFFER:
    ManageOfferResult.Encode(stream, encodedOperationResultTr.CreatePassiveOfferResult);
    break;
    case OperationType.OperationTypeEnum.SET_OPTIONS:
    SetOptionsResult.Encode(stream, encodedOperationResultTr.SetOptionsResult);
    break;
    case OperationType.OperationTypeEnum.CHANGE_TRUST:
    ChangeTrustResult.Encode(stream, encodedOperationResultTr.ChangeTrustResult);
    break;
    case OperationType.OperationTypeEnum.ALLOW_TRUST:
    AllowTrustResult.Encode(stream, encodedOperationResultTr.AllowTrustResult);
    break;
    case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
    AccountMergeResult.Encode(stream, encodedOperationResultTr.AccountMergeResult);
    break;
    case OperationType.OperationTypeEnum.INFLATION:
    InflationResult.Encode(stream, encodedOperationResultTr.InflationResult);
    break;
    case OperationType.OperationTypeEnum.MANAGE_DATA:
    ManageDataResult.Encode(stream, encodedOperationResultTr.ManageDataResult);
    break;
    }
    }
    public static OperationResultTr Decode(IByteReader stream) {
      OperationResultTr decodedOperationResultTr = new OperationResultTr();
    decodedOperationResultTr.Discriminant = OperationType.Decode(stream);
    switch (decodedOperationResultTr.Discriminant.InnerValue) {
    case OperationType.OperationTypeEnum.CREATE_ACCOUNT:
    decodedOperationResultTr.CreateAccountResult = CreateAccountResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.PAYMENT:
    decodedOperationResultTr.PaymentResult = PaymentResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.PATH_PAYMENT:
    decodedOperationResultTr.PathPaymentResult = PathPaymentResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.MANAGE_OFFER:
    decodedOperationResultTr.ManageOfferResult = ManageOfferResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.CREATE_PASSIVE_OFFER:
    decodedOperationResultTr.CreatePassiveOfferResult = ManageOfferResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.SET_OPTIONS:
    decodedOperationResultTr.SetOptionsResult = SetOptionsResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.CHANGE_TRUST:
    decodedOperationResultTr.ChangeTrustResult = ChangeTrustResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.ALLOW_TRUST:
    decodedOperationResultTr.AllowTrustResult = AllowTrustResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.ACCOUNT_MERGE:
    decodedOperationResultTr.AccountMergeResult = AccountMergeResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.INFLATION:
    decodedOperationResultTr.InflationResult = InflationResult.Decode(stream);
    break;
    case OperationType.OperationTypeEnum.MANAGE_DATA:
    decodedOperationResultTr.ManageDataResult = ManageDataResult.Decode(stream);
    break;
    }
      return decodedOperationResultTr;
    }

  }
}
}
