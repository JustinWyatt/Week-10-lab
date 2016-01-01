'use strict'
app.factory('pinFactory', function ($http) {

    var factory = {};

    factory.getPins = function () {
        return $http.get('/home/getpins').then(function (response) {
            console.log(response);
            return response.data;
        }, function (response) {
            console.log(response);
        });
    };

    factory.uploadPin = function (data) {
        return $http.post('/home/uploadpin', data).then(function (response) {
            return response.data;
        });
    };

    return factory;
});
