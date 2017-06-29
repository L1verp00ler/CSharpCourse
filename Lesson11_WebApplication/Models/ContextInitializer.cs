using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson11_WebApplication.Models
{
    public class ContextInitializer : DropCreateDatabaseAlways<DocumentsContextDb>
    {
        //добавляем значения по умолчанию при создании бд
        protected override void Seed(DocumentsContextDb context)
        {
            #region TestWords

            var word = new Word() { NameWord = "телефон" };
            var word2 = new Word() { NameWord = "купить" };
            var word3 = new Word() { NameWord = "новый" };
            var word4 = new Word() { NameWord = "в" };
            var word5 = new Word() { NameWord = "москва" };
            var word6 = new Word() { NameWord = "иваново" };
            var word7 = new Word() { NameWord = "samsung" };
            var word8 = new Word() { NameWord = "iphone" };
            var word9 = new Word() { NameWord = "операционная" };
            var word10 = new Word() { NameWord = "система" };
            var word11 = new Word() { NameWord = "android" };
            var word12 = new Word() { NameWord = "mac" };
            var word13 = new Word() { NameWord = "недорого" };

            context.Words.AddRange(new List<Word>()
            {
                word,
                word2,
                word3,
                word4,
                word5,
                word6,
                word7,
                word8,
                word9,
                word10,
                word11,
                word12,
                word13
            });
            #endregion

            #region TestDocuments

            var document = new Document()
            {
                NameDocument = "Текст1",
                Words = new List<Word>() { word, word2, word3, word4, word7, word9, word10, word11 }
            };

            context.Documents.Add(document);

            var document2 = new Document()
            {
                NameDocument = "Текст2",
                Words = new List<Word>() { word, word2, word3, word4, word5, word8, word9, word10, word12, word13 }
            };

            context.Documents.Add(document2);

            var document3 = new Document()
            {
                NameDocument = "Текст3",
                Words = new List<Word>()
                {
                    word,
                    word2,
                    word3,
                    word4,
                    word5,
                    word8,
                    word9,
                    word10,
                    word12,
                    word13,
                    word6,
               }
            };

            context.Documents.Add(document3);
            #endregion

            context.SaveChanges();
        }
    }
}