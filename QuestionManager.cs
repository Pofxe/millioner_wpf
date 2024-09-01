using System.Collections.Generic;

namespace MillionaireGame
{
    public class QuestionManager
    {
        public List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>
            {
                new Question("Кем был мужчина, послуживший моделью для известной картины «Американская готика» Гранта Вуда?", new List<Answer>
                {
                    new Answer("Коммивояжером", false),
                    new Answer("Местным шерифом", false),
                    new Answer("Его зубным врачом", true),
                    new Answer("Его мясником", false)
                }),
                new Question("Какое насекомое вызвало короткое замыкание в ранней версии вычислительной машины, тем самым породив термин «компьютерный баг»?", new List<Answer>
                {
                    new Answer("Таракан", false),
                    new Answer("Муха", false),
                    new Answer("Мотылек", true),
                    new Answer("Японский хрущик", false)
                }),
                new Question("Из каких плодов можно получить копру?", new List<Answer>
                {
                    new Answer("Ананас", false),
                    new Answer("Кокос", true),
                    new Answer("Вишня", false),
                    new Answer("Абрикос", false)
                }),
                new Question("Под каким названием известна единица с последующими ста нулями?", new List<Answer>
                {
                    new Answer("Мегатрон", false),
                    new Answer("Гигабит", false),
                    new Answer("Гугол", true),
                    new Answer("Наномоль", false)
                }),
                new Question("Какой химический элемент составляет более половины массы тела человека?", new List<Answer>
                {
                    new Answer("Кислород", true),
                    new Answer("Углерод", false),
                    new Answer("Кальций", false),
                    new Answer("Железо", false)
                }),
                new Question("Сколько кубиков в кубике Рубика?", new List<Answer>
                {
                    new Answer("54", true),
                    new Answer("56", false),
                    new Answer("63", false),
                    new Answer("45", false)
                }),
                new Question("Что изобразил Юджин Сернан, последний на данный момент побывавший на Луне человек, на ее поверхности?", new List<Answer>
                {
                    new Answer("Символ мира", false),
                    new Answer("«Боже, храни Америку»", false),
                    new Answer("Инициалы дочери", true),
                    new Answer("«Здесь был Юджин»", false)
                }),
                new Question("Что изображено на заднем плане картины Леонардо да Винчи «Мона Лиза»?", new List<Answer>
                {
                    new Answer("Драпировка", false),
                    new Answer("Город", false),
                    new Answer("Пейзаж", true),
                    new Answer("Стадо овец", false)
                }),
                new Question("Одним из направлений какой религиозной философии является учение дзен?", new List<Answer>
                {
                    new Answer("Даосизм", false),
                    new Answer("Буддизм", true),
                    new Answer("Индуизм", false),
                    new Answer("Иудаизм", false)
                }),
                new Question("Какую страну не пересекает экватор?", new List<Answer>
                {
                    new Answer("Кения", false),
                    new Answer("Панама", true),
                    new Answer("Бразилия", false),
                    new Answer("Индонезия", false)
                }),
                new Question("Кто из перечисленных был пажом во времена Екатерины II?", new List<Answer>
                {
                    new Answer("Д.И.Фонвизин", false),
                    new Answer("Г.Р.Державин", false),
                    new Answer("Н.М.Карамзин", false),
                    new Answer("А.Н.Радищев", true)
                }),
                new Question("Какая единица измерения названа в честь итальянского дворянина?", new List<Answer>
                {
                    new Answer("Паскаль", false),
                    new Answer("Вольт", true),
                    new Answer("Ом", false),
                    new Answer("Герц", false)
                }),
                new Question("Сколько морей омывают Балканский полуостров?", new List<Answer>
                {
                    new Answer("3", false),
                    new Answer("4", false),
                    new Answer("5", false),
                    new Answer("6", true)
                }),
                new Question("Что случилось с исландским островом Сюртсей 14 ноября 1963 года?", new List<Answer>
                {
                    new Answer("Появился из моря", true),
                    new Answer("Покрылся льдом", false),
                    new Answer("Раскололся надвое", false),
                    new Answer("Стал полуостровом", false)
                }),
                new Question("Кого держит в кармане скупой человек, если верить народной французской присказке?", new List<Answer>
                {
                    new Answer("Чижа", false),
                    new Answer("Хомяка", false),
                    new Answer("Ежа", true),
                    new Answer("Цыпленка", false)
                })
            };
            return questions;
        }
    }
    
}