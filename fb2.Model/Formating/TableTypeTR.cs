namespace fb2.Model.Formating
{
    using System.ComponentModel;
    using System.Xml.Serialization;

    using fb2.Model.Enum;

    /// <summary>
    ///     The table type tr.
    /// </summary>
    /// <remarks>
    /// </remarks>
    [XmlType(AnonymousType = true, Namespace = "http://www.gribuser.ru/xml/fictionbook/2.0")]
    public class TableTypeTr
    {
        /// <summary>
        ///     The align field.
        /// </summary>
        private AlignType alignField;

        /// <summary>
        ///     The td field.
        /// </summary>
        private PType[] tdField;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TableTypeTr" /> class.
        /// </summary>
        public TableTypeTr()
        {
            this.alignField = AlignType.left;
        }

        /// <summary>
        ///     The td.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlElement("td")]
        public PType[] td
        {
            get
            {
                return this.tdField;
            }

            set
            {
                this.tdField = value;
            }
        }

        /// <summary>
        ///     The align.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [XmlAttribute]
        [DefaultValue(AlignType.left)]
        public AlignType align
        {
            get
            {
                return this.alignField;
            }

            set
            {
                this.alignField = value;
            }
        }
    }
}