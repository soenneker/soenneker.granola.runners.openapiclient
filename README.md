[![](https://img.shields.io/github/actions/workflow/status/soenneker/Soenneker.Granola.Runners.OpenApiClient/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/Soenneker.Granola.Runners.OpenApiClient/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/Soenneker.Granola.Runners.OpenApiClient/daily-automatic-update.yml?style=for-the-badge&label=Daily%20Update)](https://github.com/soenneker/Soenneker.Granola.Runners.OpenApiClient/actions/workflows/daily-automatic-update.yml)

# Soenneker.Granola.Runners.OpenApiClient

Orchestrates the filesystem work required to refresh the generated Granola OpenAPI client from its source specification.

> This is an automation runner, not a package intended for application consumption.

## What the runner does

- `IFileOperationsUtil.Process(cancellationToken)` — Downloads the current Granola specification, applies the repository's compatibility fixes, and regenerates the client source.

## What you get

- `IFileOperationsUtil` — Orchestrates the filesystem work required to refresh the generated Granola OpenAPI client from its source specification.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IFileOperationsUtil.Process(cancellationToken)` | Downloads the current Granola specification, applies the repository's compatibility fixes, and regenerates the client source. | A task that completes after the generated client files have been updated. |

## Practical notes

- Cancellation stops pending work; it does not undo work that has already completed.
