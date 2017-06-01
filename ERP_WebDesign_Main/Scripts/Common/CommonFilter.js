(function () {
    'use strict';

    var filterModule = angular.module('ERP-FILTER', []);

    filterModule.filter('dateconvert', function () {
        return function (input) {
            return (moment(input).format('MM/DD/YYYY hh:mm:ss a')).toUpperCase();
        }
    });

})();



