using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;

namespace adessoTaskApi.Mappers
{
    public class GroupMapper
    {
        public static List<GroupDTO> entityToDtoList(List<Group> groups)
        {
            return groups.Select(c => EntityToDTO(c)).ToList();
        }
        public static List<Group> DtoToEntityList(List<GroupDTO> groups)
        {
            return groups.Select(c => DTOToEntity(c)).ToList();
        }
        public static GroupDTO EntityToDTO(Group group)
        {

            return new GroupDTO
            {
                GroupId = (byte)group.GroupId,
                GroupName = group.GroupName
            };

        }
        public static Group DTOToEntity(GroupDTO group)
        {

            return new Group
            {
                GroupId = (byte)group.GroupId,
                GroupName = group.GroupName
            };

        }
    }
}

