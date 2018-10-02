angular.module('swabhav.modA', ['swabhav.modB', 'swabhav.modC', 'populateModule'])
    .controller('controllerA', function ($scope, $rootScope) {
        console.log("Inside controllerA..");
        $rootScope.students = [
            {
                name: "dharmesh",
                id: 1
            },
            {
                name: "chandan",
                id: 2
            }

        ];
        $scope.msg = "Hello from controller A";
        $rootScope.company = "HiTech";
    });

angular.module('swabhav.modB', [])
    .controller('controllerB', function ($scope, $rootScope) {
        console.log("Inside controllerB..");
        $scope.msg = "Hello from controller B";
        console.log($rootScope.company);
    });

angular.module('swabhav.modC', [])
    .controller('controllerC', function ($scope, $rootScope) {
        console.log("Inside controllerC..");
        $scope.msg = "Hello from controller C";
        console.log($rootScope.company);
    });





