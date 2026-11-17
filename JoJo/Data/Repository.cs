using JoJo.Models;

namespace JoJo.Data;

public class Repository
{
    private readonly List<Character> characters;

    public Repository()
    {
        characters = new List<Character>
        {
            new Character
            {
                Id = 1,
                Name = "Джонатан Джостар",
                Part = "Phantom Blood (Часть 1)",
                Stand = "—",
                Description = "Первый ДжоДжо. Благородный и добрый джентльмен, мастер боевых искусств.",
                UrlPhoto = "https://i.pinimg.com/736x/cf/7a/80/cf7a809bcb5cce074f0ed6d6488ed08a.jpg"
            },
            new Character
            {
                Id = 2,
                Name = "Джозеф Джостар",
                Part = "Battle Tendency (Часть 2)",
                Stand = "Hermit Purple",
                Description = "Внук Джонатана. Хитрый и находчивый, использует Хамона в бою.",
                UrlPhoto = "https://i.pinimg.com/736x/3c/4f/e7/3c4fe7e5bb4d93091f64afc8d1c8135e.jpg?nii=t"
            },
            new Character
            {
                Id = 3,
                Name = "Дзётаро Кудзё",
                Part = "Stardust Crusaders (Часть 3)",
                Stand = "Star Platinum",
                Description = "Самый известный ДжоДжо. Спокойный и решительный, владеет мощным Стендом.",
                UrlPhoto = "https://i.pinimg.com/originals/a9/9c/6a/a99c6aca8644814e5eb827e93c69f39c.jpg?nii=t"
            },
            new Character
            {
                Id = 4,
                Name = "Джоскэ Хигашиката",
                Part = "Diamond is Unbreakable (Часть 4)",
                Stand = "Crazy Diamond",
                Description = "Внебрачный сын Джозефа. Добродушный парень, способный восстанавливать предметы.",
                UrlPhoto = "https://cdn.kanobu.ru/articles/pics/2207d913-c72e-42e3-9106-7f237ca6e5bc.jpg"
            },
            new Character
            {
                Id = 5,
                Name = "Джорно Джованна",
                Part = "Golden Wind (Часть 5)",
                Stand = "Gold Experience",
                Description = "Сын DIO. Мечтает стать «Ганг-звездой» и борется с мафией.",
                UrlPhoto = "https://i.pinimg.com/736x/e6/1c/61/e61c61bfe1abeaa387a996079ce0d763.jpg"
            },
            new Character
            {
                Id = 6,
                Name = "Джолин Кудзё",
                Part = "Stone Ocean (Часть 6)",
                Stand = "Stone Free",
                Description = "Дочь Дзётаро. Отважная девушка, сражающаяся за свободу в тюрьме.",
                UrlPhoto = "https://i.pinimg.com/originals/81/ec/f1/81ecf1d461bb6c66dbf79e6ac1009379.png?nii=t"
            },
            new Character
            {
                Id = 7,
                Name = "Джонни Джостар",
                Part = "Steel Ball Run (Часть 7)",
                Stand = "Tusk",
                Description = "Парализованный жокей, участник гонки «Steel Ball Run», ищущий исцеление.",
                UrlPhoto = "https://i.pinimg.com/736x/66/ad/e2/66ade2df93db3e8ea883e7300b998d8b.jpg"
            },
            new Character
            {
                Id = 8,
                Name = "Джодио Джостар",
                Part = "JoJolion (Часть 8)",
                Stand = "Soft & Wet",
                Description = "Загадочный юноша с амнезией, обладающий силой пузырей.",
                UrlPhoto = "https://i.pinimg.com/736x/75/6a/39/756a39aef225e029d4c78ee1d7752175.jpg"
            }
        };
    }

    public List<Character> GetAll() => characters;
}
