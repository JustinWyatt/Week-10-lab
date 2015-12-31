var app = angular.module("app", ['ngRoute', 'ngResource']).config(function ($routeProvider) {
    $routeProvider.when('home/index', { controller: 'HomeController', templateUrl: 'pinterest.cshtml' })
                  .otherwise({ redirectTo: '/index' });
});

app.factory('factory', function ($http) {
    var factory = {};

    factory.uploadPin = function (data) {
        return $http.post('inventories/uploadpin', data).then(function success(data) {
            console.log(data);

        });
    }
});

app.controller('PinController', ['$scope', 'factory', function ($scope, factory) {
    $scope.uploadpin = factory.uploadPin(pin);

    var pin = { image: $scope.image, url: $scope.url };

}]);



