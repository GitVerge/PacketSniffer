using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("creature_equip_template")]
    public sealed class CreatureEquipment
    {
		[DBFieldName ("ID")]
		public uint ID;

        [DBFieldName("itemID1")]
        public uint ItemEntry1;

        [DBFieldName("itemID2")]
        public uint ItemEntry2;

        [DBFieldName("itemID3")]
        public uint ItemEntry3;
    }
}
