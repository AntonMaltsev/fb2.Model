namespace fb2.Model.Description
{
    using System.ComponentModel;
    using System.Xml.Serialization;

    using fb2.Model.Types;

    /// <summary>
    ///     The fiction book description titleinfo genre.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionTitleinfoGenre
    {
        /// <summary>
        ///     The match field.
        /// </summary>
        private string matchField;

        /// <summary>
        ///     The value field.
        /// </summary>
        private string valueField;

        /// <summary>
        ///     Initializes a new instance of the <see cref="FictionBookDescriptionTitleinfoGenre" /> class.
        /// </summary>
        public FictionBookDescriptionTitleinfoGenre()
        {
            this.matchField = "100";
        }

        /// <summary>
        ///     The match.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute(DataType = "integer")]
        [DefaultValue("100")]
        public string match
        {
            get
            {
                return this.matchField;
            }

            set
            {
                this.matchField = value;
            }
        }

        /// <summary>
        ///     The value.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlText]
        public string Value
        {
            get
            {
                return this.valueField;
            }

            set
            {
                this.valueField = value;
            }
        }
    }
}