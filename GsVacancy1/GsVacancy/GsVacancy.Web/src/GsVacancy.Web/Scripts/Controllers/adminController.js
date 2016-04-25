//(function () {
//    'use strict';

//    angular
//        .module('adminApp')
//        .controller('adminController', adminController);

//    adminController.$inject = ['$scope', 'Vacancies'];

//    function adminController($scope, Vacancies) {
//        $scope.vacancies = Vacancies.query();
//    }
//})();
(function () {
    'use strict';

    angular
        .module('adminApp')
        .controller('vacancyListController', vacancyListController)
        .controller('vacancyCreateController', vacancyCreateController)
        .controller('vacancyEditController', vacancyEditController)
        .controller('vacancyDeleteController', vacancyDeleteController);

    
    vacancyListController.$inject = ['$scope', 'Vacancies'];

    function vacancyListController($scope, Vacancies) {
               $scope.vacancies = Vacancies.query();
            }

   
    vacancyCreateController.$inject = ['$scope', '$location', 'Vacancies'];

    function vacancyCreateController($scope, $location, Vacancies) {
        $scope.vacancies = new Vacancies();
        $scope.add = function () {
            $scope.vacancies.$save(function () {
                $location.path('/');
            });
        };
    }

   
    vacancyEditController.$inject = ['$scope', '$routeParams', '$location', 'Vacancies'];

    function vacancyEditController($scope, $routeParams, $location, Vacancies) {
        $scope.vacancies = Vacancies.get({ id: $routeParams.id });
        $scope.edit = function () {
            $scope.vacancies.$save(function () {
                $location.path('/');
            });
        };
    }

    
    vacancyDeleteController.$inject = ['$scope', '$routeParams', '$location', 'Vacancies'];

    function vacancyDeleteController($scope, $routeParams, $location, Vacancies) {
        $scope.vacancies = Vacancies.get({ id: $routeParams.id });
        $scope.remove = function () {
            $scope.vacancies.$remove({ id: $scope.movie.Id }, function () {
                $location.path('/');
            });
        };
    }


})();
