// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChatUserTyping : TLUpdateBase 
	{
		public TLUpdateChatUserTyping() { }
		public TLUpdateChatUserTyping(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateChatUserTyping; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			ChatId = from.ReadInt32();
			UserId = from.ReadInt32();
			Action = TLFactory.Read<TLSendMessageActionBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x9A65EA1F);
			to.Write(ChatId);
			to.Write(UserId);
			to.WriteObject(Action, cache);
			if (cache) WriteToCache(to);
		}
	}
}