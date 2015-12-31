'use strict';
app.factory('ordersService', ['$http', function ($http) {

    var serviceBase = 'http://localhost:61051/';
    var pinsServiceFactory = {};

    var _getPins = function () {

        return $http.get(serviceBase + 'api/getpins/id').then(function (results) {
            return results;
        });
    };

    pinsServiceFactory.getPins = _getOrders;

    return pinsServiceFactory;

}]);