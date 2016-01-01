'use strict'
app.controller('pinController', ['$scope', 'pinFactory',  function ($scope, pinFactory) {

    $scope.pinList = [];

    var init = function () {
        pinFactory.getPins().then(function (results) {
            $scope.pinList = results;
        });
    }

    init();

    $scope.makeUpload = function (newPin) {
        pinFactory.uploadPin(newPin).then(function (result) {
            $scope.pinList.unshift(result);
            console.log(result);
            $scope.newPin = "";
        });
    }
}]);