app.controller("bolumCtrl", ['$scope', '$http',
function ($scope, $http) {
    $scope.mesaj = "Bölüm çalışıyor...";

    $http.get("../Api/Kurs/getAll").then(function (response) {
        $scope.myData = response.data;

    });

    $scope.save = function () {
        $http.post("../Api/Kurs/Insert", $scope.Model).then(function (item) {
            $scope.Model = item.data;
        })
    };
}]);


//~/Api/Kurs/getAll