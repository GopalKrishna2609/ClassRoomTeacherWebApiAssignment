namespace ClassTeacherAPIProject.APImodel
{
    public class TeacherAndClassRoomApiModel
    {

        public TeacherApiModel Teacher { get; set; }

        public List<ClassRoomApiModel> ClassroomList { get; set; }
       
    }
}
