          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Ess.Generated
{


// === xdr source ============================================================
//  enum PublicKeyType
//  {
//      PUBLIC_KEY_TYPE_ED25519 = KEY_TYPE_ED25519
//  };
//  ===========================================================================
public class PublicKeyType {
  public enum PublicKeyTypeEnum
  {
  PUBLIC_KEY_TYPE_ED25519 = 0,
  }

  public PublicKeyTypeEnum InnerValue { get; set; } = default(PublicKeyTypeEnum);

  public static PublicKeyType Create(PublicKeyTypeEnum v)
  {
    return new PublicKeyType {
      InnerValue = v
    };
  }

  public static PublicKeyType Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 0: return Create(PublicKeyTypeEnum.PUBLIC_KEY_TYPE_ED25519);
			default:
			  throw new System.Exception("Unknown enum value: " + value);
		  }
		}

		public static void Encode(IByteWriter stream, PublicKeyType value) {
		  XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
		}
}
}
