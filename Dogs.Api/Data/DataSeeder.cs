using Dogs.Api.Models;
using System.Linq;
using System.Collections.Generic;

namespace Dogs.Api.Data
{
    public static class DataSeeder
    {
        private const string url = "https://i.pinimg.com/736x/f4/d2/96/f4d2961b652880be432fb9580891ed62.jpg";
        public static Breed[] breeds = GetBreeds();
        public static List<Dog> dogs = GetDogs();
        //public const string[] imgUrls = new string[6] {
        //        "https://i.pinimg.com/736x/f4/d2/96/f4d2961b652880be432fb9580891ed62.jpg",
        //        "https://storage.theoryandpractice.ru/tnp/uploads/image_unit/000/156/586/image/base_87716f252d.jpg",
        //        "https://thumbs.dreamstime.com/b/golden-retriever-dog-21668976.jpg",
        //        "https://media.istockphoto.com/id/498649047/photo/three-dogs.jpg?s=612x612&w=0&k=20&c=dJ0h0o1UOkkoB18XNgrjUkccH2_O201N3yws7zTS9eM=",
        //        "https://images.unsplash.com/photo-1548199973-03cce0bbc87b?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NHx8ZG9nc3xlbnwwfHwwfHw%3D&w=1000&q=80",
        //        "https://media.istockphoto.com/id/169958839/photo/golden-retriever-family.jpg?s=612x612&w=0&k=20&c=IeHKytrjrO0uyk713A9h5jspo9Dx2YqydkiogxSJc98=",
        //        "https://images.unsplash.com/photo-1519594774370-0b631f3d527e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8NXx8ZG9nJTIwZmFjZXxlbnwwfHwwfHw%3D&w=1000&q=80"
        //    };

        public static Breed[] GetBreeds()
        {
            var breed1 = new Breed() { Description = "lol", Id = Guid.NewGuid(), Name = "Normas" };
            var breed2 = new Breed() { Description = "lol2", Id = Guid.NewGuid(), Name = "Kal" };
            var breed3 = new Breed() { Description = "lol3", Id = Guid.NewGuid(), Name = "Napas Lavandos" };
            var breed4 = new Breed() { Description = "lol4", Id = Guid.NewGuid(), Name = "Na Vorotnishok" };
            var breed5 = new Breed() { Description = "lol5", Id = Guid.NewGuid(), Name = "Lopaos" };
            var breeds = new Breed[]
            {
                breed1, breed2, breed3, breed4, breed5
            };
            return breeds;
        }
        public static List<Dog> GetDogs()
        {
            var dogs = new List<Dog>();

            dogs.Add(new Dog()
            {
                Id = Guid.NewGuid(),
                Name = "крот",
                ImgUrl = url,
                Description = "wqertyujhgfdsvbn",
                ShortDescription = "dog",
                Breed = breeds[0],
                MaxAge = 12,
                MinAge = 9,
                MaxHeight = 100,
                MinHeight = 50,
                MaxWeight = 90,
                MinWeight = 50,
            });
            dogs.Add(new Dog()
            {
                Id = Guid.NewGuid(),
                Name = "крffffhт",
                ImgUrl = url,
                Description = "wqujhgfdsvbn",
                ShortDescription = "dog2",
                Breed = breeds[1],
                MaxAge = 12,
                MinAge = 9,
                MaxHeight = 100,
                MinHeight = 50,
                MaxWeight = 90,
                MinWeight = 50,
            });


            var dog1 = new Dog()
            {
                Id = Guid.NewGuid(),
                Name = "буааа",
                ImgUrl = url,
                Description = "wqertyujhgfdsvbn",
                ShortDescription = "c0000oo",
                Breed = breeds[3],
                MaxAge = 12,
                MinAge = 9,
                MaxHeight = 100,
                MinHeight = 50,
                MaxWeight = 90,
                MinWeight = 50,
            };


            var dog = new Dog()
            {
                Id = Guid.NewGuid(),
                Name = "кро!!!!!!!!!!!!!!!т",
                ImgUrl = "https://storage.theoryandpractice.ru/tnp/uploads/image_unit/000/156/586/image/base_87716f252d.jpg",
                Description = "wqehgfdsvbn",
                ShortDescription = "dog",
                Breed = breeds[4],
                MaxAge = 12,
                MinAge = 9,
                MaxHeight = 100,
                MinHeight = 50,
                MaxWeight = 90,
                MinWeight = 50,
            };

            dogs.AddRepeated(dog, 100);
            dogs.AddRepeated(dog1, 100);
            dogs.AddRepeated(dog, 50);


            return dogs;
        }
    }


    public static class Mod
    {

        public static void AddRepeated(this List<Dog>? self, Dog? item, int count)
        {
            for (int i = 0; i < count; i++)
            {
                //int imgRnIndex = random.Next(0, 5);
                int breedRnIndex = new Random().Next(0, DataSeeder.breeds.Length);

                var maxAgeRn = new Random().Next(10, 20);
                var maxHeightRn = new Random().Next(20, 70);
                var maxWeightRn = new Random().Next(30, 80);

                Dog item1;

                item1 = new Dog()
                {
                    Id = Guid.NewGuid(),
                    Name = Convert.ToString(i),
                    ImgUrl = item.ImgUrl,
                    Description = item.ShortDescription,
                    ShortDescription = item.ShortDescription,
                    Breed = DataSeeder.breeds[breedRnIndex],
                    MaxAge = maxAgeRn,
                    MinAge = new Random().Next(5, maxAgeRn),
                    MaxHeight = maxHeightRn,
                    MinHeight = new Random().Next(10, maxHeightRn),
                    MaxWeight = maxWeightRn,
                    MinWeight = new Random().Next(5, maxWeightRn)
                };

                self.Add(item1);
            }
        }
    }

}