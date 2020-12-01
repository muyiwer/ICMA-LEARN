var CourseScore = function(){
    var dt = $('#hidden-table-info').DataTable();
    var domain = location.protocol+'//'+location.hostname+(location.port ? ':'+location.port: '');
    var GetCourseScores = function(){
        $('.spin').hide();
        $.get( domain + "/api/Course/GetScore", function(data, status){
            console.log(data);
            //console.log(dt);
            var counter = 0;
            data.forEach(element => {
                
                counter = counter + 1
                console.log(counter)
                dt.fnAddData( [
                    counter ,
                    element.name,
                    element.CourseCategoryName,
                    element.courseHighiestScore === null ? "" : element.courseHighiestScore.fullName,
                    element.courseHighiestScore === null ? "" : element.courseHighiestScore.score
                ] );
            });
           
          });
    }

    return {
        //main function to initiate the module
        init: function() {
            GetCourseScores();
        }

    };

}();