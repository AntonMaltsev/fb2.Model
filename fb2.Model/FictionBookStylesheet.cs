namespace fb2.Model
{
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The fiction book stylesheet.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookStylesheet : BaseTextData
    {
        /// <summary>
        ///     The type.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        public string type { get; set; }

        /// <summary>
        ///     The value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        [XmlText]
        public override string Text { get; set; }
    }
}