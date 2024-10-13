using AutoMapper;
using System.ComponentModel;

namespace automapper_practice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var source = new Source
            {
                Id = 1,
                Name = "John Doe"
            };


            var config = new MapperConfiguration(cfg =>
                        cfg.CreateMap<Source, Destination>()
                        .ForMember(x => x.FullName, y => y.MapFrom(x => x.Name))); // 註冊Model間的對映
            var mapper = config.CreateMapper(); // 建立 Mapper

            var destination = mapper.Map<Destination>(source);
        }
    }

    public class Source
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Destination
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }

}