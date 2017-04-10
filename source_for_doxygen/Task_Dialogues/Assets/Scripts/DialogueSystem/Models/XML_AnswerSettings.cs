using System.Xml;
using System.Xml.Serialization;

namespace DialogueSystemScripts.Models
{
    /** \addtogroup XML_Models
    *  @{
        */

    /// <summary>
    /// Класс настроек ответа из XML.
    /// </summary>
    [System.Serializable]
    public class XML_AnswerSettings
    {
        /// <summary>
        /// Текст диалога.
        /// </summary>
        [XmlText]
        public string Text
        {
            private set;
            get;
        }
    }
    /** @}*/
}