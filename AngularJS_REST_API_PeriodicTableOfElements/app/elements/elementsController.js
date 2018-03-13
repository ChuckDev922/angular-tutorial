(function () {
	// fetch all elements
	var elementsController = function ($scope, $filter, remoteElementsService) {
	    $scope.fetchElements = function () {
            remoteElementsService.fetchElements()
			.success(function (data, status, headers, config) {
			    $scope.elements = data;
			})
			.error(function (data, status, headers, config) {
			    $scope.elements = null;
			    $scope.error = "Failed to retrieve item from server: id=";
			});
	    };

		// fetch element by ID
		$scope.fetchElement = function (id) {
			
			if (id == -1) {
				alert('See Lanthanides section');
				return;
			}
			else if (id == -2) {
				alert('See Actinides section');
				return;
			}
			console.log('elementsController: element id = ' + id);
			remoteElementsService.fetchElement(id)
			.success(function (data, status, headers, config) {
				$scope.singleElement = data;
				console.log('elementsController success: element id = ' + $scope.singleElement.ID);
			})
			.error(function (data, status, headers, config) {
				$scope.singleElement = null;
				$scope.error = "Failed to retrieve item from server: id=" + id;
			});
		};
		
	}

	angular.module('myAngularApplicationElements').controller('elementsController', ["$scope", "$filter", "remoteElementsService",  elementsController]);
}());