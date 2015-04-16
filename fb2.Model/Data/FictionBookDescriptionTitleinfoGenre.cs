namespace fb2.Model.Data
{
    using System.ComponentModel;
    using System.Xml.Serialization;

    using fb2.Model.Base;

    /// <summary>
    ///     The fiction book description titleinfo genre.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionTitleinfoGenre : BaseTextData
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="FictionBookDescriptionTitleinfoGenre" /> class.
        /// </summary>
        public FictionBookDescriptionTitleinfoGenre()
        {
            this.match = "100";
        }

        /// <summary>
        ///     The match.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "integer")]
        [DefaultValue("100")]
        public string match { get; set; }

        /// <summary>
        ///     The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlText]
        public override string Text { get; set; }
    }
}