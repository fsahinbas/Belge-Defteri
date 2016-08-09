app.controller("kursCtrl", ['$scope', '$http',
function ($scope, $http) {

    $http.get("../Api/Kurs/getAll").then(function (response) {
        $scope.kurslar = response.data;

    });

    $scope.save = function () {
        $http.post("../Api/Kurs/insert", $scope.Model).then(function (item) {
            $scope.Model = item.data;
        })
    };

    $scope.update = function () {
        $http.post("../Api/Kurs/update", $scope.Model).then(function (item) {
            $scope.Model = item.data;
        })
    };

    $scope.show = function (course) {
        $scope.Model = course;
        console.log($scope.Model);
        $('#updateKursModal').modal('show');
    };

    $scope.del = function (course) {
        var onay = window.confirm("Silmek istediğinizden emin misiniz?")
        if (onay) {
            $http.post("../Api/Kurs/del/"+course.Id).then(function () {
                $http.get("../Api/Kurs/getAll").then(function (data) {
                    $scope.kurslar = data.data;
                })
            });
        }
    }

}]);
