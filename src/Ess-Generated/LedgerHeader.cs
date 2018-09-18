          // Automatically generated by xdrgen 
          // DO NOT EDIT or your changes may be overwritten

          namespace Ess.Generated
{


// === xdr source ============================================================
//  struct LedgerHeader
//  {
//      uint32 ledgerVersion;    // the protocol version of the ledger
//      Hash previousLedgerHash; // hash of the previous ledger header
//      StellarValue scpValue;   // what consensus agreed to
//      Hash txSetResultHash;    // the TransactionResultSet that led to this ledger
//      Hash bucketListHash;     // hash of the ledger state
//  
//      uint32 ledgerSeq; // sequence number of this ledger
//  
//      int64 totalCoins; // total number of stroops in existence.
//                        // 10,000,000 stroops in 1 XLM
//  
//      int64 feePool;       // fees burned since last inflation run
//      uint32 inflationSeq; // inflation sequence number
//  
//      uint64 idPool; // last used global ID, used for generating objects
//  
//      uint32 baseFee;     // base fee per operation in stroops
//      uint32 baseReserve; // account base reserve in stroops
//  
//      uint32 maxTxSetSize; // maximum size a transaction set can be
//  
//      Hash skipList[4]; // hashes of ledgers in the past. allows you to jump back
//                        // in time without walking the chain back ledger by ledger
//                        // each slot contains the oldest ledger that is mod of
//                        // either 50  5000  50000 or 500000 depending on index
//                        // skipList[0] mod(50), skipList[1] mod(5000), etc
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };
//  ===========================================================================
public class LedgerHeader {
  public LedgerHeader () {}
  public Uint32 LedgerVersion { get; set; }
  public Hash PreviousLedgerHash { get; set; }
  public StellarValue ScpValue { get; set; }
  public Hash TxSetResultHash { get; set; }
  public Hash BucketListHash { get; set; }
  public Uint32 LedgerSeq { get; set; }
  public Int64 TotalCoins { get; set; }
  public Int64 FeePool { get; set; }
  public Uint32 InflationSeq { get; set; }
  public Uint64 IdPool { get; set; }
  public Uint32 BaseFee { get; set; }
  public Uint32 BaseReserve { get; set; }
  public Uint32 MaxTxSetSize { get; set; }
  public Hash[] SkipList { get; set; }
  public LedgerHeaderExt Ext { get; set; }
  public static void Encode(IByteWriter stream, LedgerHeader encodedLedgerHeader) {
    Uint32.Encode(stream, encodedLedgerHeader.LedgerVersion);
    Hash.Encode(stream, encodedLedgerHeader.PreviousLedgerHash);
    StellarValue.Encode(stream, encodedLedgerHeader.ScpValue);
    Hash.Encode(stream, encodedLedgerHeader.TxSetResultHash);
    Hash.Encode(stream, encodedLedgerHeader.BucketListHash);
    Uint32.Encode(stream, encodedLedgerHeader.LedgerSeq);
    Int64.Encode(stream, encodedLedgerHeader.TotalCoins);
    Int64.Encode(stream, encodedLedgerHeader.FeePool);
    Uint32.Encode(stream, encodedLedgerHeader.InflationSeq);
    Uint64.Encode(stream, encodedLedgerHeader.IdPool);
    Uint32.Encode(stream, encodedLedgerHeader.BaseFee);
    Uint32.Encode(stream, encodedLedgerHeader.BaseReserve);
    Uint32.Encode(stream, encodedLedgerHeader.MaxTxSetSize);
    int skipListsize = encodedLedgerHeader.SkipList.Length;
    for (int i = 0; i < skipListsize; i++) {
      Hash.Encode(stream, encodedLedgerHeader.SkipList[i]);
    }
    LedgerHeaderExt.Encode(stream, encodedLedgerHeader.Ext);
  }
  public static LedgerHeader Decode(IByteReader stream) {
    LedgerHeader decodedLedgerHeader = new LedgerHeader();
    decodedLedgerHeader.LedgerVersion = Uint32.Decode(stream);
    decodedLedgerHeader.PreviousLedgerHash = Hash.Decode(stream);
    decodedLedgerHeader.ScpValue = StellarValue.Decode(stream);
    decodedLedgerHeader.TxSetResultHash = Hash.Decode(stream);
    decodedLedgerHeader.BucketListHash = Hash.Decode(stream);
    decodedLedgerHeader.LedgerSeq = Uint32.Decode(stream);
    decodedLedgerHeader.TotalCoins = Int64.Decode(stream);
    decodedLedgerHeader.FeePool = Int64.Decode(stream);
    decodedLedgerHeader.InflationSeq = Uint32.Decode(stream);
    decodedLedgerHeader.IdPool = Uint64.Decode(stream);
    decodedLedgerHeader.BaseFee = Uint32.Decode(stream);
    decodedLedgerHeader.BaseReserve = Uint32.Decode(stream);
    decodedLedgerHeader.MaxTxSetSize = Uint32.Decode(stream);
    int skipListsize = 4;
    decodedLedgerHeader.SkipList = new Hash[skipListsize];
    for (int i = 0; i < skipListsize; i++) {
      decodedLedgerHeader.SkipList[i] = Hash.Decode(stream);
    }
    decodedLedgerHeader.Ext = LedgerHeaderExt.Decode(stream);
    return decodedLedgerHeader;
  }

  public class LedgerHeaderExt {
    public LedgerHeaderExt () {}
    public int Discriminant { get; set; } = new int();
    public static void Encode(IByteWriter stream, LedgerHeaderExt encodedLedgerHeaderExt) {
    XdrEncoding.EncodeInt32(encodedLedgerHeaderExt.Discriminant, stream);
    switch (encodedLedgerHeaderExt.Discriminant) {
    case 0:
    break;
    }
    }
    public static LedgerHeaderExt Decode(IByteReader stream) {
      LedgerHeaderExt decodedLedgerHeaderExt = new LedgerHeaderExt();
    decodedLedgerHeaderExt.Discriminant = XdrEncoding.DecodeInt32(stream);
    switch (decodedLedgerHeaderExt.Discriminant) {
    case 0:
    break;
    }
      return decodedLedgerHeaderExt;
    }

  }
}
}
