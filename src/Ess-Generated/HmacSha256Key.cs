          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Ess.Generated
{


// === xdr source ============================================================
//  struct HmacSha256Key
//  {
//          opaque key[32];
//  };
//  ===========================================================================
public class HmacSha256Key {
  public HmacSha256Key () {}
  public byte[] Key { get; set; }
  public static void Encode(IByteWriter stream, HmacSha256Key encodedHmacSha256Key) {
    int keysize = encodedHmacSha256Key.Key.Length;
    XdrEncoding.WriteFixOpaque(stream, (uint)keysize, encodedHmacSha256Key.Key);
  }
  public static HmacSha256Key Decode(IByteReader stream) {
    HmacSha256Key decodedHmacSha256Key = new HmacSha256Key();
    int keysize = 32;
    decodedHmacSha256Key.Key = XdrEncoding.ReadFixOpaque(stream, (uint)keysize);
    return decodedHmacSha256Key;
  }
}
}
