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
            Souding = false;
            _cage = cage;
            _cage.HaveFoodEvent += (s, e) => 
            {
                HaveFoodEvent haveFoodEvent = (HaveFoodEvent)e;
                Food = haveFoodEvent.Food;
                if (Food == Food.Seed)
                {
                    Eat();
                }
                else
                {
                    DetectSound();
                }
            };
            MakeSoundEvent += (s, e) =>
            {
                MakeSoundEvent makeSoundEvent = (MakeSoundEvent)e;

                makeSoundEvent.Animal.Speak(makeSoundEvent.Sound);

            };

            MimicEvent += MimicPublisher;
        }

        public Parrot(Guid code, string name)
        {
            Code = code;
            Name = name;
        }
        public void MimicPublisher(object sender, EventArgs e)
        {
            MimicEvent mimicEvent = (MimicEvent)e;
            Copy(mimicEvent.Sound);
            //UnSubscribeEvent();
        }
        public override void Eat()
        {
            Console.WriteLine($"Parrot-{Name} đang ăn {Food}");
        }
        public override void Speak(string sound)
        {
            Console.WriteLine($"Parrot-{Name} kêu {sound}");
        }
        public void Copy(string skill)
        {
            Speak(skill);
        }
        public void UnSubscribeEvent()
        {
            MimicEvent -= MimicPublisher;
        }
    }
}
