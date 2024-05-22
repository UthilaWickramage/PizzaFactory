pipeline {
    agent { 
        node {
            label 'master'
            }
      }
    triggers {
        pollSCM '* * * * *'
    }
    stages {
        stage('Build') {
            steps {
                echo "Building.."
                sh '''
                cd PizaFactory
                '''
            }
        }
        stage('Test') {
            steps {
                echo "Testing.."
                sh '''
                cd PizaFactory
                dotnet Program.cs
                '''
            }
        }
        stage('Deliver') {
            steps {
                echo 'Deliver....'
                sh '''
                echo "doing delivery stuff.."
                '''
            }
        }
    }
}

