using System;
using Zoo.EventHelper;
using Zoo.Interface;
using Zoo.ZooManagement;

namespace Zoo
{
    public class Parrot : Herbivore, IIntelligent
    {
        public override Guid Code { get => base.Code; set => base.Code = value; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override bool Scary { get => base.Scary; set => base.Scary = value; }
        public override string Sound { get; set; }

        public Parrot() {}
        public Parrot(Cage cage)
        {
            _cage = cage;
            _cage.HaveFoodEvent += (s, e) => 
            {
                HaveFoodEvent haveFoodEvent = (HaveFoodEvent)e;
                Food = haveFoodEvent.Food;
                if (Food == Food.Seed)
                {
                    Eat();
                }
                Copy();
            };
            MimicEvent += (s, e) =>
            {
                MimicEvent mimicEvent = (MimicEvent)e;
                foreach (var ani in _cage.animals)
                {
                    if (ani.Souding)
                    {
                        Speak(ani.Sound);
                    }
                }
            };
        }

        public Parrot(Guid code, string name)
        {
            Code = code;
            Name = name;
        }
        public override void Eat()
        {
            Console.WriteLine($"Parrot-{Name} đang ăn {Food}");
        }
        public override void Speak(string sound)
        {
            Console.WriteLine($"Parrot-{Name} kêu éc");
        }
        public void Copy()
        {
            DetectSound(null);
        }
    }
}
