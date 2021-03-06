using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Spectacles.NET.Types;

namespace Skyra.Core.Cache.Models
{
	public class CachedMessage
	{
		public CachedMessage(Message message)
		{
			Id = message.Id;
			ChannelId = message.ChannelId;
			GuildId = message.GuildId;
			Content = message.Content;
			Embeds = message.Embeds;
			Timestamp = message.Timestamp;
			Attachments = message.Attachments;
			EditedTimestamp = message.EditedTimestamp;
		}

		[JsonConstructor]
		public CachedMessage(string id, string channelId, string guildId, string content, List<Embed> embeds,
			DateTime timestamp, List<Attachment> attachments, DateTime? editedTimestamp)
		{
			Id = id;
			ChannelId = channelId;
			GuildId = guildId;
			Content = content;
			Embeds = embeds;
			Timestamp = timestamp;
			Attachments = attachments;
			EditedTimestamp = editedTimestamp;
		}

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("cid")]
		public string ChannelId { get; set; }

		[JsonProperty("gid")]
		public string GuildId { get; set; }

		[JsonProperty("c")]
		public string Content { get; set; }

		[JsonProperty("e")]
		public List<Embed> Embeds { get; set; }

		[JsonProperty("a")]
		public List<Attachment> Attachments { get; set; }

		[JsonProperty("t")]
		public DateTime Timestamp { get; set; }

		[JsonProperty("et")]
		public DateTime? EditedTimestamp { get; set; }
	}
}
