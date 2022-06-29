
using System.Xml;

class Book
{
    public string Genre { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }

}
static class Program
{
    #region   Read Xml - and display on console  
    static void Main(string[] args)
    {
        Console.WriteLine("Products");
        Console.WriteLine("----------------------");

        using var reader = XmlReader.Create("C:\\Xml\\products.xml");

        reader.MoveToContent();

        while (reader.Read())
        {
            string result = reader.NodeType switch
            {
                XmlNodeType.Element when reader.Name == "product" => $"{reader.Name}\n",
                XmlNodeType.Element => $"{reader.Name}: ",
                XmlNodeType.Text => $"{reader.Value}\n",
                XmlNodeType.EndElement when reader.Name == "product" => "-------------------\n",
                _ => ""
            };

            Console.Write(result);

        }
        Console.WriteLine("Executed successfully");
    }
    #endregion

    #region   Write Xml -create xml list  from c# object  
    //static void Main(string[] args)
    //{
    //    var books = new List<Book>()
    //    {
    //      new Book(){ Genre="Science Fiction",Title ="Birthday",Author ="Mirabel",Price =8.88M,},
    //      new Book(){ Genre="Novel",Title ="Biafran Day",Author ="Annabel",Price =9.98M,},
    //      new Book(){ Genre="History",Title ="The Exodus",Author ="Karim",Price =3.98M,},
    //    };
    //    XmlDocument xmlDoc = new XmlDocument();
    //    XmlNode rootNode = xmlDoc.CreateElement("books");
    //    xmlDoc.AppendChild(rootNode);
    //    for(int i = 0; i < books.Count; i++)
    //    {
    //        XmlNode bookNode = xmlDoc.CreateElement("book");
    //        XmlNode genreChild = xmlDoc.CreateElement("genre");
    //        genreChild.InnerText = books[i].Genre;
    //        bookNode.AppendChild(genreChild);

    //        XmlNode titleChild = xmlDoc.CreateElement("title");
    //        titleChild.InnerText = books[i].Title;
    //        bookNode.AppendChild(titleChild);

    //        XmlNode authorChild = xmlDoc.CreateElement("author");
    //        authorChild.InnerText = books[i].Author;
    //        bookNode.AppendChild(authorChild);

    //        XmlNode priceChild = xmlDoc.CreateElement("price");
    //        priceChild.InnerText = books[i].Price.ToString();
    //        bookNode.AppendChild(priceChild);
    //        rootNode.AppendChild(bookNode);
    //    }
    //    xmlDoc.Save("C:\\Xml\\books.xml");
    //    Console.WriteLine("Executed successfully");
    //}
    #endregion

    #region   Read Xml attribute values dynamically  
    //static void Main(string[] args)
    //{

    //    Console.WriteLine("XmlTextReader Properties Test");
    //    Console.WriteLine("===================");

    //    XmlDocument xmlDoc = new XmlDocument();
    //    xmlDoc.Load("C:\\Xml\\test-doc.xml");
    //    XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");

    //    for(int i=0;i<userNodes.Count;i++)
    //    {
    //        XmlNode node = userNodes[i];
    //        Console.WriteLine();
    //        Console.Write("User: " + node.InnerText);
    //        Console.Write("  Age: " + node.Attributes["age"].Value);
    //    }
    //    Console.WriteLine();
    //    Console.WriteLine("Executed successfully");
    //}
    #endregion



    #region   Update Xml attribute values dynamically 2 --object oriented way
    //static void Main(string[] args)
    //{
    //    XmlDocument xmlDoc = new XmlDocument();
    //    xmlDoc.Load("C:\\Xml\\test-doc.xml");
    //    XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
    //    foreach (XmlNode userNode in userNodes)
    //    {
    //        int age = int.Parse(userNode.Attributes["age"].Value);
    //        userNode.Attributes["age"].Value = (age + 1).ToString();
    //    }

    //    xmlDoc.Save("C:\\Xml\\test-doc.xml");
    //    Console.WriteLine("Executed successfully");
    //}
    #endregion


    #region   Write Xml 2 --object oriented way
    //static void Main(string[] args)
    //{
    //    XmlDocument xmlDoc = new XmlDocument();
    //    XmlNode rootNode = xmlDoc.CreateElement("users");
    //    xmlDoc.AppendChild(rootNode);

    //    XmlNode userNode = xmlDoc.CreateElement("user");
    //    XmlAttribute attribute = xmlDoc.CreateAttribute("age");
    //    attribute.Value = "42";
    //    userNode.Attributes.Append(attribute);
    //    userNode.InnerText = "John Doe";
    //    rootNode.AppendChild(userNode);

    //    userNode = xmlDoc.CreateElement("user");
    //    attribute = xmlDoc.CreateAttribute("age");
    //    attribute.Value = "39";
    //    userNode.Attributes.Append(attribute);
    //    userNode.InnerText = "Jane Doe";
    //    rootNode.AppendChild(userNode);

    //    xmlDoc.Save("C:\\Xml\\test-doc.xml");
    //    Console.WriteLine("Executed successfully");
    //}
    #endregion



    #region   Load Xml
    //static void Main(string[] args)
    //{
    //    //Create the XmlDocument.  
    //    XmlDocument doc = new XmlDocument();
    //    doc.LoadXml(("<Student type='regular' Section='B'><Name>Tommy   ex </Name></Student > "));   
    //    //Save the document to a file.  
    //    doc.Save("C:\\Xml\\std.xml");

    //    Console.WriteLine("Executed successfully");
    //}
    #endregion



    #region   Write Xml
    //static void Main(string[] args)
    //{
    //    // Create a new file in C:\\ dir  
    //    XmlTextWriter textWriter = new XmlTextWriter(@"C:\\Xml\\myXmFile.xml", null);
    //   // TextWriter textWriter = new StreamWriter(@"c:\data.xml");
    //    // Opens the document  
    //    textWriter.WriteStartDocument();
    //    // Write comments  
    //    textWriter.WriteComment("First Comment XmlTextWriter Sample Example");
    //    textWriter.WriteComment("myXmlFile.xml in root dir");
    //    // Write first element  
    //    textWriter.WriteStartElement("Student");
    //    textWriter.WriteStartElement("r", "RECORD", "urn:record");
    //    // Write next element  
    //    textWriter.WriteStartElement("Name", "");
    //    textWriter.WriteString("Student");
    //    textWriter.WriteEndElement();
    //    // Write one more element  
    //    textWriter.WriteStartElement("Address", "");
    //    textWriter.WriteString("Colony");
    //    textWriter.WriteEndElement();
    //    // WriteChars  
    //    char[] ch = new char[3];
    //    ch[0] = 'a';
    //    ch[1] = 'r';
    //    ch[2] = 'c';
    //    textWriter.WriteStartElement("Char");
    //    textWriter.WriteChars(ch, 0, ch.Length);
    //    textWriter.WriteEndElement();
    //    // Ends the document.  
    //    textWriter.WriteEndDocument();
    //    // close writer  
    //    textWriter.Close();
    //}
    #endregion

}

