          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Ess.Generated
{


// === xdr source ============================================================
//  typedef opaque DataValue<64>;
//  ===========================================================================
public class DataValue {
  public byte[] InnerValue { get; set; } = default(byte[]);
            
  public DataValue() { }
  public DataValue(byte[] DataValue)
  {
    InnerValue = DataValue;
  }
  public static void Encode(IByteWriter stream, DataValue  encodedDataValue) {
  int DataValueSize = encodedDataValue.InnerValue.Length;
  XdrEncoding.EncodeInt32(DataValueSize, stream);
  XdrEncoding.WriteFixOpaque(stream, (uint)DataValueSize, encodedDataValue.InnerValue);
  }
  public static DataValue Decode(IByteReader stream) {
    DataValue decodedDataValue = new DataValue();
  int DataValuesize = XdrEncoding.DecodeInt32(stream);
  decodedDataValue.InnerValue = XdrEncoding.ReadFixOpaque(stream, (uint)DataValuesize);
    return decodedDataValue;
  }
}
}
