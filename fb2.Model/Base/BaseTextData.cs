namespace fb2.Model.Base
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The base data.
    /// </summary>
    public class BaseTextData : BaseFormatingStyle
    {
        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        /// <value>
        ///     The value.
        /// </value>
        [XmlText]
        public virtual string Text { get; set; }

        /// <summary>
        ///     Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        ///     A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Text;
        }
    }
}