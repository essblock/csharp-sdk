          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Ess.Generated
{


// === xdr source ============================================================
//  enum AccountFlags
//  { // masks for each flag
//  
//      // Flags set on issuer accounts
//      // TrustLines are created with authorized set to "false" requiring
//      // the issuer to set it for each TrustLine
//      AUTH_REQUIRED_FLAG = 0x1,
//      // If set, the authorized flag in TrustLines can be cleared
//      // otherwise, authorization cannot be revoked
//      AUTH_REVOCABLE_FLAG = 0x2,
//      // Once set, causes all AUTH_* flags to be read-only
//      AUTH_IMMUTABLE_FLAG = 0x4
//  };
//  ===========================================================================
public class AccountFlags {
  public enum AccountFlagsEnum
  {
  AUTH_REQUIRED_FLAG = 1,
  AUTH_REVOCABLE_FLAG = 2,
  AUTH_IMMUTABLE_FLAG = 4,
  }

  public AccountFlagsEnum InnerValue { get; set; } = default(AccountFlagsEnum);

  public static AccountFlags Create(AccountFlagsEnum v)
  {
    return new AccountFlags {
      InnerValue = v
    };
  }

  public static AccountFlags Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 1: return Create(AccountFlagsEnum.AUTH_REQUIRED_FLAG);
      case 2: return Create(AccountFlagsEnum.AUTH_REVOCABLE_FLAG);
      case 4: return Create(AccountFlagsEnum.AUTH_IMMUTABLE_FLAG);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, AccountFlags value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
