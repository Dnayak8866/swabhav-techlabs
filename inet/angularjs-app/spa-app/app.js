angular.module('swabhav', ['ngRoute'])
    .config(function ($routeProvider) {
        $routeProvider.when("/home", {
            controller: 'homeController',
            templateUrl: 'templates/home.html'
        })
            .when("/about", {
                controller: 'aboutController',
                templateUrl: 'templates/about.html'
            })
            .when("/career", {
                controller: 'careerController',
                templateUrl: 'templates/career.html'
            });
    })
    .controller('homeController', function ($scope) {
        $scope.homedata = "Home data.......";
    })
    .controller('aboutController', function ($scope) {
        $scope.aboutdata = "About data.......";
    })
    .controller('careerController', function ($scope) {
        $scope.careerdata = "Career data.....";
    });