# fb2.Model
#### Serialazible Fiction Book v. 2.0 model based on native XSDs.

<br/>
##### What is FB2
FictionBook is an open XML-based e-book format. The FictionBook format does not specify the appearance of a document; instead, it describes it's structure. 
All ebook metadata, such as author name, title, and publisher, is also present in the ebook file.This makes the format convenient for automatic processing, indexing, and ebook collection management, and allows automatic conversion into other formats.
More on [wiki](https://en.wikipedia.org/wiki/FictionBook)
<br/>
##### How to use
Standard C# serialization working perfectly with it.
So all you need to do is:

    var xmlSerializer = new XmlSerializer(typeof(FictionBook));
    using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
    {
          using (var reader = XmlReader.Create(stream))
          {
              var result = (XmlSerializer)xmlSerializer.Deserialize(reader);
              return result;
          }
    }
