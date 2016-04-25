//var adminServices = angular.module('adminServices', ['ngResource']);
//adminServices.factory('Vacancies', Vacancies);
//Vacancies.$inject = ['$resource'];

//function Vacancies($resource) {
//    return $resource('/api/admins');
//}
(function () {
    'use strict';

    angular
        .module('adminServices', ['ngResource'])
        .factory('Vacancies', Vacancies);

    Vacancies.$inject = ['$resource'];

    function Vacancies($resource) {
        return $resource('/api/admins/:id');
    }
})();