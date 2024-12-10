namespace PrototypePattern;

public class Document(string title, string content, Tag tag)
    : IPrototype<Document>
{
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;

    public Tag Tag { get; set; } = tag;

    public Document Clone()
    {
        return (MemberwiseClone() as Document)!;
    }

    public Document DeepClone()
    {
        var clone = Clone();
        clone.Tag = new Tag(Tag.Name, Tag.Value);
        return clone;
    }
}