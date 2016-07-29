app.controller("bolumCtrl", ['$scope', '$http',
function ($scope,$http) {
    $scope.mesaj = "Bölüm çalışıyor...";
    $http.get("../Api/Kurs/getAll").then(function (response) {
        $scope.myData = response.data;
    });
}]);


    //~/Api/Kurs/getAll