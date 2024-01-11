using Entities.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.Json.Serialization;

namespace Entities;
public class Todo : IEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("_id")]
    [JsonPropertyName("_id")]
    public string Id { get; set; }
    [BsonElement("content")]
    public string Content { get; set; }
    [BsonElement("date")]
    public DateTime Date { get; set; }
    [BsonElement("completed")]
    public bool Completed { get; set; }
}