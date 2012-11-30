﻿namespace Lex.Db.Serialization
{
  internal enum KnownDbType : short
  {
    Dict = -2,
    List = -1,
    String = 0,
    Byte = 1,
    Integer = 2,
    Boolean = 3,
    Float = 4,
    Double = 5,
    Decimal = 6,
    Guid = 7,
    DateTime = 8,
    TimeSpan = 9,
    Long = 10
  }
}
