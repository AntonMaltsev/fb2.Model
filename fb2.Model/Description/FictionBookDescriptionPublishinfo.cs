namespace fb2.Model.Description
{
    using System.Xml.Serialization;

    using fb2.Model.Data;

    /// <summary>
    ///     The fiction book description publishinfo.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class FictionBookDescriptionPublishinfo
    {
        /// <summary>
        ///     The bookname field.
        /// </summary>
        private TextFieldType booknameField;

        /// <summary>
        ///     The city field.
        /// </summary>
        private TextFieldType cityField;

        /// <summary>
        ///     The isbn field.
        /// </summary>
        private TextFieldType isbnField;

        /// <summary>
        ///     The publisher field.
        /// </summary>
        private TextFieldType publisherField;

        /// <summary>
        ///     The sequence field.
        /// </summary>
        private SequenceType[] sequenceField;

        /// <summary>
        ///     The year field.
        /// </summary>
        private string yearField;

        /// <summary>
        ///     The bookname.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("book-name")]
        public TextFieldType bookname
        {
            get
            {
                return this.booknameField;
            }

            set
            {
                this.booknameField = value;
            }
        }

        /// <summary>
        ///     The publisher.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType publisher
        {
            get
            {
                return this.publisherField;
            }

            set
            {
                this.publisherField = value;
            }
        }

        /// <summary>
        ///     The city.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType city
        {
            get
            {
                return this.cityField;
            }

            set
            {
                this.cityField = value;
            }
        }

        /// <summary>
        ///     The year.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement(DataType = "gYear")]
        public string year
        {
            get
            {
                return this.yearField;
            }

            set
            {
                this.yearField = value;
            }
        }

        /// <summary>
        ///     The isbn.
        /// </summary>
        /// <remarks>
        /// </remarks>
        public TextFieldType isbn
        {
            get
            {
                return this.isbnField;
            }

            set
            {
                this.isbnField = value;
            }
        }

        /// <summary>
        ///     The sequence.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("sequence")]
        public SequenceType[] sequence
        {
            get
            {
                return this.sequenceField;
            }

            set
            {
                this.sequenceField = value;
            }
        }
    }
}