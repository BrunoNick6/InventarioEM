using InventarioEM.NewFolder;

namespace InventarioEM.Repository
{
    public interface Arearepository
    {
        IEnumerable<Area> GetAll();
        Area GetById(int id);
        void Add(Area area);
        void Update(Area area);
        void Delete(Area area);
    }

    public class AreaRepository : Arearepository
    {
        /*private readonly InventarioContext _context;

        public AreaRepository(InventarioContext context)
        {
           _context = context;
        }
        */
        public IEnumerable<Area> GetAll()
        {
            return _context.Areas.ToList();
        }

        public Area GetById(int id)
        {
            return _context.Areas.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Area area)
        {
            _context.Areas.Add(area);
            _context.SaveChanges();
        }

        public void Update(Area area)
        {
            _context.Areas.Update(area);
            _context.SaveChanges();
        }

        public void Delete(Area area)
        {
            _context.Areas.Remove(area);
            _context.SaveChanges();
        }
    }

}
