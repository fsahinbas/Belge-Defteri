app.controller("kursCtrl", ['$scope', '$http',
function ($scope, $http) {

    $http.get("../Api/Kurs/getAll").then(function (response) {
        $scope.kurslar = response.data;

    });

    $scope.save = function () {
        $http.post("../Api/Kurs/Insert", $scope.Model).then(function (item) {
            $scope.Model = item.data;
        })
    };

    //Seçilen kursa ait data modala aktarılıyor

    $scope.show = function (course) {
        console.log(course);
        $scope.Model = course;
        console.log($scope.Model);
        $('#kursModal').modal('show');
    };

}]);
