var adminApp = angular.module('adminApp', ["ngRoute", 'adminServices'])
    .config(function ($routeProvider) {
        $routeProvider
            .when('/',
        {
            templateUrl: 'views/list.html',
            controller: 'vacancyListController'
        })
        .when('/add',
        {
            templateUrl: 'views/addvacancy.html',
            controller: 'vacancyCreateController'
        })
        .when('edit/:id', {
            templateUrl: '/views/edit.html',
            controller: 'vacancyEditController'
        })
            .when('delete/:id', {
                templateUrl: '/views/delete.html',
                controller: 'vacancyDeleteController'
            });
    });
    

   
        
    
    



