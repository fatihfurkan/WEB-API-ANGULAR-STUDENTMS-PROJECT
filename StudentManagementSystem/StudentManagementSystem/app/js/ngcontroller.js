var app = angular.module('sms', []);
app.controller('studentCntrl', function ($scope, $http) {
    
    GetStudent();
    function GetStudent() {
        debugger;
        $http.get("http://localhost:54377/api/Student/GetStudent")
            .then(function (response) {
                debugger;
                $scope.student = response.data;
            });
    }
    $scope.save = function (Student) {
        debugger;
        $http.post("http://localhost:54377/api/Student/InsertStudent", Student)
            .then(function (response) {
                debugger;
                GetStudent();
            });
    }
});