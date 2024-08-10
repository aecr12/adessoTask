using adessoTaskApi.Data;
using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;

namespace adessoTaskApi.Business
{
    public class GroupBusiness
    {
        public static async Task InsertAllGroups(IDAO<Group> _group, List<Group> groups)
        {
            try
            {
                await _group.CreateAsync(groups);
            }
            catch (Exception e)
            {
                throw;
            }

        }

    }
}
