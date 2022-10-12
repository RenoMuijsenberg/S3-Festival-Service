[![Build And Test](https://github.com/RenoMuijsenberg/S3-Festival-Service/actions/workflows/main.yml/badge.svg)](https://github.com/RenoMuijsenberg/S3-Festival-Service/actions/workflows/main.yml)
[![Push Image To DockerHub](https://github.com/RenoMuijsenberg/S3-Festival-Service/actions/workflows/docker-image.yaml/badge.svg)](https://github.com/RenoMuijsenberg/S3-Festival-Service/actions/workflows/docker-image.yaml)
[![SonarCloud Scan](https://github.com/RenoMuijsenberg/S3-Festival-Service/actions/workflows/sonar-cloud.yaml/badge.svg)](https://github.com/RenoMuijsenberg/S3-Festival-Service/actions/workflows/sonar-cloud.yaml)

![01-startup-series-dribbble](https://user-images.githubusercontent.com/43666923/191457379-8ff28917-14c5-443e-a3c7-dd6e91b93713.gif)
# Festival service
This repository is a small part of a project that I'm making for school, you can read about the project [here](https://github.com/RenoMuijsenberg/S3-Festival-Planner-Angular/wiki).

# Endpoints:
## GET
Get all festivals:
```
/api/festival/festivals
```
Get specific festival:
```
/api/festival/festivals/{festival name}
```
