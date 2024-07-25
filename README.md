# Deploy .NET API endpoint into AWS Lambda
How can we deploy a .NET api endpoint (GET /api/weatherforecast) into a lambda


### Steps:
1. be sure you have set an AWS profile locally with AdministratorAccess policy
1. Create simple .NET project
1. install sam cli: https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/install-sam-cli.html
1. dotnet tool install -g Amazon.Lambda.Tools
1. manually create cole-cli-s3 bucket in aws console
1. add StartupLambda.cs file
1. add LambdaEntryPoint.cs file in **deployment** folder and be sure you have UseStartup<Program>
1. right click on project and select add aws serverless template
1. rename template.yml, move it to **deployment** folder (in root) add here RootResource

#### Steps to deploy
1. go to deploymkent folder
1. run >sam build
1. run >sam validate
1. go to where the .csproj file is
1. run  >sam deploy --profile test-bog-dev1 --stack-name core-cli-stk --s3-bucket core-cli-s3 --capabilities CAPABILITY_IAM -t deployment/template.yml
1. result: we have our endpoint GET https://<some_id>.execute-api.eu-west-1.amazonaws.com/dev/api/weatherforecast
1. Later we can include these 2 commands in a pipeline


##### Links
[Creating & deploying a .NET Core Web API to AWS with the Serverless Framework](https://www.karam.io/blog/2019/creating-and-deploying-a-net-core-web-api-to-aws-with-the-serverless-framework/)<br>
[Serverless Framework  - Deploying to AWS](https://www.serverless.com/framework/docs/providers/aws/guide/deploying)<br>
[Serverless Framework  - CLI - AWS - deploy](https://www.serverless.com/framework/docs/providers/aws/cli-reference/deploy)<br>
[Serverless Framework - An Introduction](https://www.serverless.com/framework/docs)<br>
[Serverless Framework - AWS Lambda Functions](https://www.serverless.com/framework/docs/providers/aws/guide/functions)<br>
[AWS - Deploy an Existing ASP.NET Core Web API to AWS Lambda](https://aws.amazon.com/blogs/developer/deploy-an-existing-asp-net-core-web-api-to-aws-lambda/)<br>
[AWS - Deploying an AWS Lambda Project with the .NET Core CLI](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-cli-publish.html)<br>
[github - AWS Extensions for .NET CLI](https://github.com/aws/aws-extensions-for-dotnet-cli?tab=readme-ov-file#aws-lambda-amazonlambdatools)<br>
[Build and deploy C# Lambda functions with .zip file archives](https://docs.aws.amazon.com/lambda/latest/dg/csharp-package.html)