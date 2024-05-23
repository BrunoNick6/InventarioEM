using InventarioEM.NewFolder;

namespace InventarioEM
{
    public interface AreaService
    {
        IEnumerable<Area> GetAllAreas();
        Area GetAreaById(int id);
        void AddArea(Area area);
        void UpdateArea(Area area);
        void DeleteArea(int id);
    }

    /*public class Areaservice : Areaservice
    {
        private readonly Arearepository _areaRepository;

        public Areaservice(Arearepository areaRepository)
        {
            _areaRepository = areaRepository;
        }

        public IEnumerable<Area> GetAllAreas()
        {
            return _areaRepository.GetAll();
        }

        public Area GetAreaById(int id)
        {
            return _areaRepository.GetById(id);
        }

        public void AddArea(Area area)
        {
            _areaRepository.Add(area);
        }

        public void UpdateArea(Area area)
        {
            _areaRepository.Update(area);
        }

        public void DeleteArea(int id)
        {
            var area = _areaRepository.GetById(id);
            if (area != null)
                _areaRepository.Delete(area);
        }
    }

}
