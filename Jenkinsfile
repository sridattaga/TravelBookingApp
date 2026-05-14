pipeline {
  agent any
  stages {
    stage('Build') {
      steps { sh 'dotnet build src/TravelBooking.Web' }
    }
    stage('Publish') {
      steps { sh 'dotnet publish src/TravelBooking.Web -c Release -o publish' }
    }
    stage('Docker') {
      steps {
        sh 'docker build -t travelbooking:1.0 .'
      }
    }
    stage('Deploy') {
      steps {
        sh 'kubectl apply -f k8s/'
      }
    }
  }
}
