using System;

namespace Library.Models.Mapping 
{
    public class ExtensionMethodTest
    {
        static UserResponse ToResponse{caret}(this UserRequest request)
    }

    public class UserRequest
    {
        public int Prop { get; set; }
    }

    public class UserResponse
    {
        public int Prop { get; set; }
    }
}