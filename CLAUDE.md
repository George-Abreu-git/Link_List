@AGENT.md

## Específico do Claude Code
- Subagente: `code-reviewer` (`.claude/agents/code-reviewer.md`).
- **Gatilho:** quando o George disser **"teste meu código"**, invoque o subagente `code-reviewer` pela ferramenta Agent. Não invoque em outros casos, nem após `dotnet build`/`dotnet run` (sem hooks por enquanto).
- Ao invocar, não passe soluções ao subagente: ele só pergunta, nunca responde.
- `.claude/settings.local.json` é pessoal e fica fora do git; o restante de `.claude/` é versionado.
