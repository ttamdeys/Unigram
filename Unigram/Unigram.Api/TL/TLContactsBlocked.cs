// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLContactsBlocked : TLContactsBlockedBase 
	{
		public TLContactsBlocked() { }
		public TLContactsBlocked(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.ContactsBlocked; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Blocked = TLFactory.Read<TLVector<TLContactBlocked>>(from, cache);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x1C138D15);
			to.WriteObject(Blocked, cache);
			to.WriteObject(Users, cache);
			if (cache) WriteToCache(to);
		}
	}
}