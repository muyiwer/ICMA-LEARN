var Course = function(){
    var categoryId;
   
 var domain = location.protocol+'//'+location.hostname+(location.port ? ':'+location.port: '');
    var handleCreateCourse = function(){
        $("#submit").click(function(){
            $('.spin').show();
            var name = $("#name").val();
        var description = $("#description").val();
           $.ajax({
            type: "POST",
            url: domain + '/api/Course/Create',
            // The key needs to match your method's input parameter (case-sensitive).
            data: JSON.stringify({Name: name, Description: description, CategoryId: parseInt(categoryId)}),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(data){
                $('.spin').hide();
                $('#courseModal').modal('toggle')
                var name = $("#name").text("");
                var description = $("#description").text("");
                console.log(data); 
            },
            error: function(errMsg) {
                console.log(data);
            }
        });
          });
       
    }

    var GetCourseCategories = function(){
        $('.spin').hide();
        $.get( domain + "/api/Course/CourseCategories", function(data, status){
            console.log(data);
            $.each(data,function(key, value)
            {
                console.log(key)
                $("#courseCategories").append('<option value=' + value.id + '>' + value.name + '</option>');
            });
          });
    }

    var GetCategoryId = function(){
        $('#courseCategories').on('change', function() {
            categoryId = $(this).val();
            console.log( $(this).val())
          });
    }

    return {
        //main function to initiate the module
        init: function() {
            handleCreateCourse();
            GetCourseCategories();
            GetCategoryId();
        }

    };

}();